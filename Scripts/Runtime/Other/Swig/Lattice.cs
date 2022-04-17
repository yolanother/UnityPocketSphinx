//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pocketsphinx {

public class Lattice : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Lattice(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Lattice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Lattice() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pocketsphinxPINVOKE.delete_Lattice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Lattice(string path) : this(pocketsphinxPINVOKE.new_Lattice__SWIG_0(path), true) {
  }

  public Lattice(Decoder decoder, string path) : this(pocketsphinxPINVOKE.new_Lattice__SWIG_1(Decoder.getCPtr(decoder), path), true) {
  }

  public void Write(string path) {
    pocketsphinxPINVOKE.Lattice_Write(swigCPtr, path);
  }

  public void WriteHtk(string path) {
    pocketsphinxPINVOKE.Lattice_WriteHtk(swigCPtr, path);
  }

}

}