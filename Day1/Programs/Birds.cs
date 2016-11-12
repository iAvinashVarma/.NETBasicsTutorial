namespace Animals
{
	class Birds
	{
		static void Main(string[] args)
		{
			if(args != null && args.Length > 0)
			{
				for(int i=0; i<args.Length; i++)
				{
					System.Console.WriteLine("Bird names are {0}", args[i]);
				}
			}
			// System.Console.WriteLine("Birds can fly, swim and walk.");
		}
	}
}