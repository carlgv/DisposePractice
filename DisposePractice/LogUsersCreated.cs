using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposePractice
{
	public static class LogUsersCreated
	{
		/// <summary>
		/// Gets the IUser Name and Surname, and prints to a file on desktop the hour when its created
		/// </summary>
		/// <param name="user">An IUser object</param>
		public static void PrintLogToFile(IUser user)
		{
			// Gets de path of the user desktop
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			// Creates if does not exist o append to, the file test.txt
			StreamWriter swriter = new StreamWriter(path + @"\test.txt", true);
			swriter.WriteLine("User {0} {1} created at: {2}", 
				user.Name, 
				user.Surname, 
				DateTime.Now.ToLongTimeString());
			swriter.Dispose();
		}
	}
}
