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

public class FsgModel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FsgModel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FsgModel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FsgModel() {
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
          SphinxBasePINVOKE.delete_FsgModel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public FsgModel(string Name, LogMath Logmath, float Lw, int N) : this(SphinxBasePINVOKE.new_FsgModel__SWIG_0(Name, LogMath.getCPtr(Logmath), Lw, N), true) {
  }

  public FsgModel(string Path, LogMath Logmath, float Lw) : this(SphinxBasePINVOKE.new_FsgModel__SWIG_1(Path, LogMath.getCPtr(Logmath), Lw), true) {
  }

  public int WordId(string Word) {
    int ret = SphinxBasePINVOKE.FsgModel_WordId(swigCPtr, Word);
    return ret;
  }

  public string WordStr(int Wid) {
    string ret = SphinxBasePINVOKE.FsgModel_WordStr(swigCPtr, Wid);
    return ret;
  }

  public int WordAdd(string Word) {
    int ret = SphinxBasePINVOKE.FsgModel_WordAdd(swigCPtr, Word);
    return ret;
  }

  public void TransAdd(int Src, int Dst, int Logp, int Wid) {
    SphinxBasePINVOKE.FsgModel_TransAdd(swigCPtr, Src, Dst, Logp, Wid);
  }

  public int NullTransAdd(int Src, int Dst, int Logp) {
    int ret = SphinxBasePINVOKE.FsgModel_NullTransAdd(swigCPtr, Src, Dst, Logp);
    return ret;
  }

  public int TagTransAdd(int Src, int Dst, int Logp, int Wid) {
    int ret = SphinxBasePINVOKE.FsgModel_TagTransAdd(swigCPtr, Src, Dst, Logp, Wid);
    return ret;
  }

  public int AddSilence(string Silword, int State, float Silprob) {
    int ret = SphinxBasePINVOKE.FsgModel_AddSilence(swigCPtr, Silword, State, Silprob);
    return ret;
  }

  public int AddAlt(string Baseword, string Altword) {
    int ret = SphinxBasePINVOKE.FsgModel_AddAlt(swigCPtr, Baseword, Altword);
    return ret;
  }

  public void Writefile(string Path) {
    SphinxBasePINVOKE.FsgModel_Writefile(swigCPtr, Path);
  }

  public void WritefileFsm(string Path) {
    SphinxBasePINVOKE.FsgModel_WritefileFsm(swigCPtr, Path);
  }

  public void WritefileSymtab(string Path) {
    SphinxBasePINVOKE.FsgModel_WritefileSymtab(swigCPtr, Path);
  }

  public int GetFinalState() {
    int ret = SphinxBasePINVOKE.FsgModel_GetFinalState(swigCPtr);
    return ret;
  }

  public void SetFinalState(int State) {
    SphinxBasePINVOKE.FsgModel_SetFinalState(swigCPtr, State);
  }

  public int GetStartState() {
    int ret = SphinxBasePINVOKE.FsgModel_GetStartState(swigCPtr);
    return ret;
  }

  public void SetStartState(int State) {
    SphinxBasePINVOKE.FsgModel_SetStartState(swigCPtr, State);
  }

  public int Log(double Logp) {
    int ret = SphinxBasePINVOKE.FsgModel_Log(swigCPtr, Logp);
    return ret;
  }

  public float GetLw() {
    float ret = SphinxBasePINVOKE.FsgModel_GetLw(swigCPtr);
    return ret;
  }

  public string GetName() {
    string ret = SphinxBasePINVOKE.FsgModel_GetName(swigCPtr);
    return ret;
  }

  public int GetNWord() {
    int ret = SphinxBasePINVOKE.FsgModel_GetNWord(swigCPtr);
    return ret;
  }

  public bool HasSil() {
    bool ret = SphinxBasePINVOKE.FsgModel_HasSil(swigCPtr);
    return ret;
  }

  public bool HasAlt() {
    bool ret = SphinxBasePINVOKE.FsgModel_HasAlt(swigCPtr);
    return ret;
  }

  public bool IsFiller(int Wid) {
    bool ret = SphinxBasePINVOKE.FsgModel_IsFiller(swigCPtr, Wid);
    return ret;
  }

  public bool IsAlt(int Wid) {
    bool ret = SphinxBasePINVOKE.FsgModel_IsAlt(swigCPtr, Wid);
    return ret;
  }

}

}