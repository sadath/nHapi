using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V27.Segment;
using NHapi.Model.V27.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V27.Group
{
///<summary>
///Represents the ORB_O28_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: ORC (Common Order) </li>
///<li>1: ORB_O28_TIMING (a Group object) optional repeating</li>
///<li>2: BPO (Blood product order) optional </li>
///</ol>
///</summary>
[Serializable]
public class ORB_O28_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new ORB_O28_ORDER Group.
	///</summary>
	public ORB_O28_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(ORB_O28_TIMING), false, true);
	      this.add(typeof(BPO), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORB_O28_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (Common Order) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORB_O28_TIMING (a Group object) - creates it if necessary
	///</summary>
	public ORB_O28_TIMING GetTIMING() {
	   ORB_O28_TIMING ret = null;
	   try {
	      ret = (ORB_O28_TIMING)this.GetStructure("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORB_O28_TIMING
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORB_O28_TIMING GetTIMING(int rep) { 
	   return (ORB_O28_TIMING)this.GetStructure("TIMING", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORB_O28_TIMING 
	 */ 
	public int TIMINGRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("TIMING").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ORB_O28_TIMING results 
	 */ 
	public IEnumerable<ORB_O28_TIMING> TIMINGs 
	{ 
		get
		{
			for (int rep = 0; rep < TIMINGRepetitionsUsed; rep++)
			{
				yield return (ORB_O28_TIMING)this.GetStructure("TIMING", rep);
			}
		}
	}

	///<summary>
	///Adds a new ORB_O28_TIMING
	///</summary>
	public ORB_O28_TIMING AddTIMING()
	{
		return this.AddStructure("TIMING") as ORB_O28_TIMING;
	}

	///<summary>
	///Removes the given ORB_O28_TIMING
	///</summary>
	public void RemoveTIMING(ORB_O28_TIMING toRemove)
	{
		this.RemoveStructure("TIMING", toRemove);
	}

	///<summary>
	///Removes the ORB_O28_TIMING at the given index
	///</summary>
	public void RemoveTIMINGAt(int index)
	{
		this.RemoveRepetition("TIMING", index);
	}

	///<summary>
	/// Returns BPO (Blood product order) - creates it if necessary
	///</summary>
	public BPO BPO { 
get{
	   BPO ret = null;
	   try {
	      ret = (BPO)this.GetStructure("BPO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
