﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposePractice
{
	class Program
	{
		static void Main(string[] args)
		{
			using (User u = new User())
			{
				u.GetUserData();
				u.PrintUserData();
			}
		}
	}
}
