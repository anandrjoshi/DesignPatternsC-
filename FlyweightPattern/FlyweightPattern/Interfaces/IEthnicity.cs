﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Interfaces
{
	public interface IEthnicity
	{
		List<IDisease> Diseases();
	}
}
