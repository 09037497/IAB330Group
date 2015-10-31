﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace cloud
{
	public interface IConfig
	{
		string DirectDB { get;  }
		ISQLitePlatform Platform { get; }
	}
}

