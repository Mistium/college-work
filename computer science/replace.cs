int replace(string in;string find;string repl;) {
  string output = "";
  string out = "";
  for (int i = 0;i < 1;i ++) {
    if (in[i] == find) {
      output = output + repl;
    } else {
      output = output + in[i];
    }}
  return out;
}
