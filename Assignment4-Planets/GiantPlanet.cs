using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aldrin Fernandez
 * Date: July 17, 2017
 * Description: This is the GiantPlanet class
 * Version 0.2 - created the GiantPlanet class
 */

namespace Assignment4_Planets
{
	class GiantPlanet :Planet
	{
		//PRIVATE INTANCE VARIABLES
		private string _type;


		//PUBLIC PROTPERTIES

		//CONSTRUCTOR----------------------------------------------------------------
		/// <summary>
		/// class constructor
		/// </summary>
		/// <param name="name"></param>
		/// <param name="diameter"></param>
		/// <param name="mass"></param>
		/// <param name="type"></param>
		public GiantPlanet(string name, double diameter, double mass,string type)
			: base(name, diameter, mass)
		{
			this._type = type;
		}

			

		//PUBLIC METHODS

		//PRIVATE METHODS
	}
}
