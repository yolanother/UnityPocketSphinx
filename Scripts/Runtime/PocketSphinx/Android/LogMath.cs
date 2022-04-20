//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SphinxBase {

public class LogMath : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LogMath(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LogMath obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LogMath() {
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
          SphinxBasePINVOKE.delete_LogMath(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public LogMath() : this(SphinxBasePINVOKE.new_LogMath(), true) {
  }

  public double Exp(int Prob) {
    double ret = SphinxBasePINVOKE.LogMath_Exp(swigCPtr, Prob);
    return ret;
  }

  public int Log(double Prob) {
    int ret = SphinxBasePINVOKE.LogMath_Log(swigCPtr, Prob);
    return ret;
  }

  public int Add(int LogbP, int LogbQ) {
    int ret = SphinxBasePINVOKE.LogMath_Add(swigCPtr, LogbP, LogbQ);
    return ret;
  }

  public int LnToLog(double LogP) {
    int ret = SphinxBasePINVOKE.LogMath_LnToLog(swigCPtr, LogP);
    return ret;
  }

  public double LogToLn(int LogbP) {
    double ret = SphinxBasePINVOKE.LogMath_LogToLn(swigCPtr, LogbP);
    return ret;
  }

  public int Log10ToLog(double LogP) {
    int ret = SphinxBasePINVOKE.LogMath_Log10ToLog(swigCPtr, LogP);
    return ret;
  }

  public double LogToLog10(int LogbP) {
    double ret = SphinxBasePINVOKE.LogMath_LogToLog10(swigCPtr, LogbP);
    return ret;
  }

  public float Log10ToLogFloat(double LogP) {
    float ret = SphinxBasePINVOKE.LogMath_Log10ToLogFloat(swigCPtr, LogP);
    return ret;
  }

  public double LogFloatToLog10(float LogP) {
    double ret = SphinxBasePINVOKE.LogMath_LogFloatToLog10(swigCPtr, LogP);
    return ret;
  }

}

}