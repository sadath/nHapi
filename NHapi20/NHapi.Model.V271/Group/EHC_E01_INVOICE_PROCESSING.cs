using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V271.Segment;
using NHapi.Model.V271.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V271.Group
{
///<summary>
///Represents the EHC_E01_INVOICE_PROCESSING Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: IPR (Invoice Processing Results) </li>
///</ol>
///</summary>
[Serializable]
public class EHC_E01_INVOICE_PROCESSING : AbstractGroup {

	///<summary> 
	/// Creates a new EHC_E01_INVOICE_PROCESSING Group.
	///</summary>
	public EHC_E01_INVOICE_PROCESSING(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(IPR), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating EHC_E01_INVOICE_PROCESSING - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns IPR (Invoice Processing Results) - creates it if necessary
	///</summary>
	public IPR IPR { 
get{
	   IPR ret = null;
	   try {
	      ret = (IPR)this.GetStructure("IPR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
