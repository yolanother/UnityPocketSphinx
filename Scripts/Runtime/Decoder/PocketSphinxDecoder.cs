﻿using System;
using Pocketsphinx;
using System.Collections;
using System.IO;
using TarCs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

/* Thanks for checking out my example script for PocketSphinx in Unity! :)
 * Hopefully this resource helps others to understand using this tool within Unity.
 * This example script should walk you through creating a decoder and having it recognize a custom keyphrase.
 *
 * Note: when using the standard 'en-us' language model, it doesn't seem to pickup complicated sentences well.
 * If you wish to recognize longer strings, please look at creating your own acoustic model / language model.
 *
 * IMPORTANT NOTE: It is *HIGHLY RECCOMENDED* to set your microphones sampling rate to 16000 for improved accuracy. (Higher sampling rates reduce accuracy dramatically)
 *
 * More information on CMUSphinx / PocketSphinx can be found at -> https://cmusphinx.github.io/wiki/tutorial/
 */
public class PocketSphinxDecoder : MonoBehaviour
{
    private Decoder d; // Decoder that's actually interpreting our speech.
    [Header("Configuration:")]
    public string lang = "en-us"; // The language model you wish to use. (Name of your .tar file within StreamingAssets)
    public string keyphrase = "hello world"; // The actual keyphrase our decoder is looking to recognize. Note that this is case-sensitive.

    // Events: self-explanatory.
    public delegate void SpeechRecognizedHandler(string phrase);
    public event SpeechRecognizedHandler OnSpeechRecognized;

    [SerializeField] private UnityEvent onDecoderInitialized = new UnityEvent();
    [SerializeField] private UnityEvent<string> onSpeechRecognized = new UnityEvent<string>();
    [SerializeField] private int decoderBufferSize = 5000;

    private byte[] decodingBuffer;

    private IEnumerator Start()
    {
        yield return Decompress();
        // Note: If you wish to use a LANGUAGE MODEL. Instead of looking for a keyword, uncomment SetupDecoderLM(); and comment out SetupDecoderKWS();
        SetupDecoderKWS();
        //SetupDecoderLM();
    }

    // Desc: Creates a new decoder looking for specific keyphrases.
    private void SetupDecoderKWS()
    {
        Debug.Log("<color=red>Initializing decoder...</color>");
        // Create a new configuration for our decoder.
        Config c = Decoder.DefaultConfig();
        // Find our decompressed acoustic model.
        string speechDataPath = Path.Combine(Application.persistentDataPath, lang);
        // Find our decompressed dictionary. Note: You may need to change the dictionary name if you create a custom dictionary.
        string dictPath = Path.Combine(speechDataPath, "dictionary");
        // Creates a path to store log files.
        string logPath = Path.Combine(Application.persistentDataPath, "ps.log");

        // Tell our decoder what language model we wish to use.
        c.SetString("-hmm", speechDataPath);
        // Tell our decoder what dictionary to use.
        c.SetString("-dict", dictPath);
        // Tell our decoder what phrase to look for.
        c.SetString("-keyphrase", keyphrase);

        /* IF YOU WISH TO SPOT FOR MULTIPLE KEYWORDS / PHRASES,
         * USE THE FOLLOWING CODE INSTEAD OF 'c.SetString("-keyphrase", keyphrase);'
         *
         * The following code references a txt file instead of a reference to a string.
         * It's important to note that your phrases are separated line-by-line.
         *
         * Note: Example txt file is stored at (Assets/StreamingAssets/keywords.txt)
         */
        //string keyphrasePath = Path.Combine(Application.streamingAssetsPath, "keywords.txt");
        //c.SetString("-kws", keyphrasePath);

        /* How accurate our decoder will be. For shorter keyphrases you can use smaller thresholds like 1e-1,
         * for longer keyphrases the threshold must be bigger, up to 1e-50.
         * If your keyphrase is very long – larger than 10 syllables – it is recommended to split it
         * and spot for parts separately.
         */
        c.SetFloat("-kws_threshold", 1e-15);

        // These two lines enable and save raw data to a log for debugging. Feel free to comment these lines if you have no need for logs.
        c.SetString("-logfn", logPath);
        c.SetString("-rawlogdir", Application.persistentDataPath);

        // Create a new decoder with our configuration.
        d = new Decoder(c);

        // Starts the decoder.
        d.StartUtt();

        onDecoderInitialized.Invoke();
        Debug.Log("<color=green><b>Decoder initialized!</b></color>");
    }

    // Desc: Creates a new decoder looking for any words. Instead of looking for a specific keyword, attempts to interpret what you say and turn it into text.
    private void SetupDecoderLM()
    {
        Debug.Log("<color=red>Initializing decoder...</color>");
        // Create a new configuration for our decoder.
        Config c = Decoder.DefaultConfig();
        // Find our decompressed acoustic model.
        string speechDataPath = Path.Combine(Application.persistentDataPath, lang);
        // Find our decompressed dictionary. Note: You may need to change the dictionary name if you create a custom dictionary.
        string dictPath = Path.Combine(speechDataPath, "dictionary");
        // Find our decompressed language model.
        string lmPath = Path.Combine(speechDataPath, "en-us.lm.bin");
        // Creates a path to store log files.
        string logPath = Path.Combine(Application.persistentDataPath, "ps.log");
        // Tell our decoder what language model we wish to use.
        c.SetString("-hmm", speechDataPath);
        // Tell our decoder what dictionary to use.
        c.SetString("-dict", dictPath);

        /* How accurate our decoder will be. For shorter keyphrases you can use smaller thresholds like 1e-1,
        * for longer keyphrases the threshold must be bigger, up to 1e-50.
        * If your keyphrase is very long – larger than 10 syllables – it is recommended to split it
        * and spot for parts separately.
        */
        c.SetFloat("-kws_threshold", 1e-15);

        // These two lines enable and save raw data to a log for debugging. Feel free to comment these lines if you have no need for logs.
        c.SetString("-logfn", logPath);
        c.SetString("-rawlogdir", Application.persistentDataPath);

        // Create a new decoder with our configuration.
        d = new Decoder(c);
        // Tell our decoder where our language model is located.
        d.SetLmFile("lm", lmPath);
        // Tell our decoder to use the language model to search instead of looking for a keyword.
        d.SetSearch("lm");

        // Starts the decoder.
        d.StartUtt();
        Debug.Log("<color=green><b>Decoder initialized!</b></color>");
    }

    /*  Locates and decompresses your language model.
    *   Note: This is useful if you're frequently making changes to your model, or you wish to reduce your build size.
    *   However, I would suggest decompressing your model before building as decompressing will increase your load times.
    */
    private IEnumerator Decompress()
    {
        Debug.Log("<color=red>Decompressing language model...</color>");
        // Locate your language model.
        string dataPath = Path.Combine(Application.streamingAssetsPath, lang + ".tar");
        Stream dataStream;

        // Download your language model if you wish to store it remotely.
        if (dataPath.Contains("://"))
        {
            UnityWebRequest www = UnityWebRequest.Get(dataPath);
            www.SendWebRequest();

            while (!www.isDone)
            {
                yield return null;
            }

            dataStream = new MemoryStream(www.downloadHandler.data);
        }
        // Otherwise look for the file locally.
        else
        {
            dataStream = File.OpenRead(dataPath);
        }

        TarReader reader = new TarReader(dataStream);
        // Unpack your .tar file into your persistentDataPath.
        Directory.CreateDirectory(Application.persistentDataPath);
        reader.ReadToEnd(Application.persistentDataPath);
        yield return null;

        Debug.Log("<color=green><b>Decompress complete!</b></color>");
    }

    public void Decode(byte[] buffer, int offset, int length)
    {
        if (null == d || !enabled) return;

        if (null == decodingBuffer || decodingBuffer.Length != length)
        {
            decodingBuffer = new byte[length];
        }
        Array.Copy(buffer, offset, decodingBuffer, 0, length);
        d.ProcessRaw(decodingBuffer, decodingBuffer.Length, false, false);

        // Checks if we recognize a keyphrase.
        if (d.Hyp() != null)
        {
            // Fire our event.
            if (OnSpeechRecognized != null)
            {
                OnSpeechRecognized.Invoke(d.Hyp().Hypstr);
            }
            onSpeechRecognized.Invoke(d.Hyp().Hypstr);
            Debug.Log("Recognized " + d.Hyp().Hypstr);
            // Stop the decoder.
            d.EndUtt();
            // Start the decoder again.
            d.StartUtt();
        }
    }
}
