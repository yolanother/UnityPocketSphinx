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

public class FrontEnd : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FrontEnd(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FrontEnd obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FrontEnd() {
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
          SphinxBasePINVOKE.delete_FrontEnd(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public FrontEnd() : this(SphinxBasePINVOKE.new_FrontEnd(), true) {
  }

  public int OutputSize() {
    int ret = SphinxBasePINVOKE.FrontEnd_OutputSize(swigCPtr);
    return ret;
  }

  public int ProcessUtt(string Spch, uint Nsamps, SWIGTYPE_p_p_p_mfcc_t CepBlock) {
    int ret = SphinxBasePINVOKE.FrontEnd_ProcessUtt(swigCPtr, Spch, Nsamps, SWIGTYPE_p_p_p_mfcc_t.getCPtr(CepBlock));
    return ret;
  }

}

}
