using System;
using System.Text;

namespace DisposePractice
{
	/// <summary>
	/// Class to generate a User, implementing IDisposable
	/// </summary>
	/// <see cref="IDisposable"/>
	public class User : IDisposable, IUser
	{
		public Guid Id { get; set; }
		public string Name { get; private set; }
		public string Surname { get; private set; }

		/// <summary>
		/// Opens a console window and request name and surname to the user
		/// then, sets this values to the User properties.
		/// </summary>
		/// <return>Set User Id(automaticaly generated), Name and Surname</return>
		public void GetUserData()
		{
			this.Id = Guid.NewGuid();
			Console.WriteLine("Escribe tu nombre:");
			this.Name = Console.ReadLine();
			Console.WriteLine("Escribe tu apellido:");
			this.Surname = Console.ReadLine();
		}

		/// <summary>
		/// Print in a console window the User Id, Name and Surname
		/// </summary>
		public void PrintUserData() 
		{
			Console.Clear();
			Console.Title = "USER DATA";
			StringBuilder sb = new StringBuilder();
			sb.Append("Los datos del usuario intoducido son\n\n\n");
			sb.AppendFormat("Id: {0}\nNombre: {1}\nApellido: {2}", this.Id, this.Name, this.Surname);
			Console.WriteLine(sb.ToString());
			Console.ReadLine();
		}

		#region IDisposable Support
		private bool disposedValue = false; // Para detectar llamadas redundantes

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				disposedValue = true;
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
