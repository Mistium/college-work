using System;
using System.Xml;

static bool checkbowry(double number) {
    if (Math.Floor(number * 1.5) % 59 == 0) {
        return true;
    }
    return false;
}
for (int i = 0;i < 1000;i++) {
    if (checkbowry(i) ==  true) {
        Console.WriteLine(i);
    }
}

for (int i = 0; i < 1000; i++) {
    if (Math.Floor(i * 1.5) % 59 == 0) {
        Console.WriteLine(i);
    }
}
