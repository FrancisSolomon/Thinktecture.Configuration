﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.TestTypes
{
	public interface IConfigurationWithPropertyOfConcreteType
	{
		ConfigurationWithDefaultCtor InnerConfiguration { get; }
	}
}