using System.Collections.Generic;

string[] getinstock(string[,] array) {
	List<int> termsList = new List<int>(0);
	for (int i = 0;i< array.Length;i++) {
		if (int.Parse(array[i,1]) > 0) {
			termsList = termsList.Add(i);
		}
	}
	return output;
}
