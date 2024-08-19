//Stack 

using Stacks;

Stack stack = new Stack(10);

for(int i = 0; i < 3; i++){
    stack.Push("Charizard");
    stack.Push("Venussaur");
    stack.Push("Blastoise");
}

stack.Pop();
stack.Peek();

while (!stack.isEmpty()){
    var v = stack.Pop();
    Console.WriteLine(v);
}