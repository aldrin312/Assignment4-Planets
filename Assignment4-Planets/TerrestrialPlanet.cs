using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aldrin Fernandez
 * Date: July 18, 2017
 * Description: This is the TerrestrialPlanet class
 * Version 0.3 - created the TerrestrialPlanet class
 */

namespace Assignment4_Planets
{
	class TerrestrialPlanet: Planet, IHasMoons
	{
		//PRIVATE INTANCE VARIABLES

		private bool _oxygen;

		//PUBLIC PROTPERTIES

		//CONSTRUCTOR----------------------------------------------------------------
		public TerrestrialPlanet(string name, double mass, double diameter, bool oxygen)
			: base(name,mass,diameter)
		{
			this._oxygen = oxygen;
		}
		//PUBLIC METHODS
		public bool HasMoons()
		{
			if (this.MoonCount > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool Habitable()
		{
			if (_oxygen == true)
			{
				
				return true;
			}
			else
			{
				return false;
			}

		}


		//PRIVATE METHODS

	}
}
