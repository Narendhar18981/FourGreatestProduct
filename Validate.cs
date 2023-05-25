using System;
public class Validate
{
	//the method is used to validate the given input
	public bool Is_CheckForCharAndLength(string input)
	{	
		
		if (input.Length < 4)
			throw new Exception("Enter more than 3 digits as an input");


		for(int index = 0; index <input.Length; index++)
		{
			if (!(input[index] >= 48 && input[index] <= 57))
			{
				throw new Exception("Enter only numeric values as an input");
			}
		}

		//if everything works fine then return to main code
        return true;
    }
}
