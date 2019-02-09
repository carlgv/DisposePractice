# Dispose Practice

This repository is the sample code developed to practice the using statement.


### Implement of Dispose pattern

  *	Generate new User class
    ```C#
	public class User: IDisposable
	```
	and implement de interface on the class
	```C#
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
	}
	```


*   In  `Main`, we can create a new User with using statement
	```C#
	using (User u = new User())
	{
        // Some code	
    }
    ```