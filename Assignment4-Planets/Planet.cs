using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aldrin Fernandez
 * Date: July 17, 2017
 * Description: This is the abstract planet class
 * Version 0.1 - created the planet class
 */

namespace Assignment4_Planets
{
	class Planet
	{
		//PRIVATE INTANCE VARIABLES
		private double _diameter;
		private double _mass;
		private int _moonCount;
		private string _name;
		private double _orbitalPeriod;
		private int _ringCount;
		private double _rotationalPeriod;
		//PUBLIC PROTPERTIES
		public double Diameter
		{
			get
			{
				return this._diameter;
			}
		}

		public double Mass
		{
			get
			{
				return this._mass;
			}
		}

		public int MoonCount
		{
			get
			{
				return this._moonCount;
			}
			set
			{
				this._moonCount = value;
			}
		}

		public string Name
		{
			get
			{
				return this._name;
			}
		}

		public double OrbitalPeriod
		{
			get
			{
				return this._orbitalPeriod;
			}
			set
			{
				this._orbitalPeriod = value;
			}
		}

		public int RingCount
		{
			get
			{
				return this._ringCount;
			}
			set
			{
				this._ringCount = value;
			}
		}

		public double RotationPerion
		{
			get
			{
				return this._rotationalPeriod;
			}
			set
			{
				this._rotationalPeriod = value;
			}
		}



		//CONSTRUCTOR----------------------------------------------------------------

		//PUBLIC METHIDS

		//PRIVATE METHODS
	}
}
