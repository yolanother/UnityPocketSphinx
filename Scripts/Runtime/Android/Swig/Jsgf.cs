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

public class Jsgf : global::System.Collections.IEnumerable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Jsgf(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Jsgf obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Jsgf() {
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
          SphinxBasePINVOKE.delete_Jsgf(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
     return (global::System.Collections.IEnumerator) GetEnumerator();
  }

  public JsgfIterator GetEnumerator() {
    global::System.IntPtr cPtr = SphinxBasePINVOKE.Jsgf_GetEnumerator(swigCPtr);
    JsgfIterator ret = (cPtr == global::System.IntPtr.Zero) ? null : new JsgfIterator(cPtr, true);
    return ret;
  }

  public Jsgf(string Path) : this(SphinxBasePINVOKE.new_Jsgf(Path), true) {
  }

  public string GetName() {
    string ret = SphinxBasePINVOKE.Jsgf_GetName(swigCPtr);
    return ret;
  }

  public JsgfRule GetRule(string Name) {
    global::System.IntPtr cPtr = SphinxBasePINVOKE.Jsgf_GetRule(swigCPtr, Name);
    JsgfRule ret = (cPtr == global::System.IntPtr.Zero) ? null : new JsgfRule(cPtr, false);
    return ret;
  }

  public FsgModel BuildFsg(JsgfRule Rule, LogMath Logmath, float Lw) {
    global::System.IntPtr cPtr = SphinxBasePINVOKE.Jsgf_BuildFsg(swigCPtr, JsgfRule.getCPtr(Rule), LogMath.getCPtr(Logmath), Lw);
    FsgModel ret = (cPtr == global::System.IntPtr.Zero) ? null : new FsgModel(cPtr, false);
    return ret;
  }

}

}
