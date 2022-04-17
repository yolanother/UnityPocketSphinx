//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pocketsphinx {

public class Config : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Config(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Config obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Config() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SphinxBasePINVOKE.delete_Config(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public void SetBoolean(string Key, bool Val) {
    SphinxBasePINVOKE.Config_SetBoolean(swigCPtr, Key, Val);
  }

  public void SetInt(string Key, int Val) {
    SphinxBasePINVOKE.Config_SetInt(swigCPtr, Key, Val);
  }

  public void SetFloat(string Key, double Val) {
    SphinxBasePINVOKE.Config_SetFloat(swigCPtr, Key, Val);
  }

  public void SetString(string Key, string Val) {
    SphinxBasePINVOKE.Config_SetString(swigCPtr, Key, Val);
  }

  public void SetStringExtra(string Key, string Val) {
    SphinxBasePINVOKE.Config_SetStringExtra(swigCPtr, Key, Val);
  }

  public bool Exists(string Key) {
    bool ret = SphinxBasePINVOKE.Config_Exists(swigCPtr, Key);
    return ret;
  }

  public bool GetBoolean(string Key) {
    bool ret = SphinxBasePINVOKE.Config_GetBoolean(swigCPtr, Key);
    return ret;
  }

  public int GetInt(string Key) {
    int ret = SphinxBasePINVOKE.Config_GetInt(swigCPtr, Key);
    return ret;
  }

  public double GetFloat(string Key) {
    double ret = SphinxBasePINVOKE.Config_GetFloat(swigCPtr, Key);
    return ret;
  }

  public string GetString(string Key) {
    string ret = SphinxBasePINVOKE.Config_GetString(swigCPtr, Key);
    return ret;
  }

}

}
