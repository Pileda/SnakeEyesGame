using System;
using Newtonsoft.Json;

namespace SnakeEyesGame.Models {
	[JsonObject(MemberSerialization.OptIn)]
	public class SnakeEyes {

		#region fields
		[JsonProperty]
		private Dice _eye1;
		[JsonProperty]
		private Dice _eye2;
		#endregion

		#region properties
		public int Eye1 { get; }
		public int Eye2 { get; }

		public bool HasSnakeEyes { get; }

		[JsonProperty]
		public int Total { get; set; }
		#endregion

		#region methods
		public void Play()
		{
			_eye1.roll();
			_eye2.roll();
			if (Eye1 == 1 && Eye2 == 1)
				Total = 0;
			else
				Total += Eye1 + Eye2;

		}
		#endregion

		#region constructors

		public SnakeEyes() {
			_eye1 = new Dice();
			_eye2 = new Dice();
		} 
		#endregion
	}
}