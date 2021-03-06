﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public class CoinProcessor : AbstractProcessor
	{
		public override long[] ChangeValues
		{
			get
			{
				return new long[] { 5, 10, 25, 50, 100 };
			}
		}

		public override string GetName()
		{
			return "Coin";
		}
	}
}
