using System;
using Newtonsoft.Json;

namespace SnakeEyesGame.Models {
	[JsonObject(MemberSerialization.OptIn)]
	public class Dice {

		#region fields
		private Random _r;
		#endregion

		#region properties
		[JsonProperty]
		public int Pips { get; set; }
		#endregion

		#region constructors
		public Dice() { }
		#endregion

		#region methods
		public void roll()
		{
			_r = new Random();
			Pips = 6;
		} 
		#endregion
	}
}