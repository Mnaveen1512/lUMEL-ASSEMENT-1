using System;

public class Class1
{
	public Class1()
	{

		string PRINTLIST(LIST lIST)
		{
			int n=new string[lIST.length];

			for (int i = 0 ,i < n,i++)
			{
				for (int j = 1,j < n,j++) {
					if (lIST[i] != lIST[j]) {
						return 1;
					}
					else
					{
						return 0
					}
				} 
			}
		}

		public void main()
		{
		list < new list>= [[900, 1030], [1000, 1100], [1030, 1130], [1100, 1200]];

		console.writeline(PRINTLIST(LIST));
		}

	
	}
}
