main();


void main() {
    string[] townArr = File.ReadAllLines("townArray.txt");
    string UserInp;
    while (true) {
        Console.WriteLine("Welcome to the Town Array File");
        Console.WriteLine("1. Search   2. Delete     3. Change a name");
        UserInp = Console.ReadLine();

        if (UserInp == "1") {
            Console.WriteLine("What they want to search");
            UserInp = Console.ReadLine();

            int townindex = linearSearch(townArr, UserInp);
        }
    }
}

static int linearSearch(string[] arrayin,string userinput) {
  for (int i = 0;i < arrayin.Length;i++) {
    if arrayin[i] == userinput {
      return i;
    }
  }
  return -1
}

static void deleteitem(string[] arrayin,int index) {
  File.WriteAllLines("townArray.txt", File.ReadLines(townArray.txt).Where(l => l != "removeme").ToList());
}
