﻿using LinkedList;
Console.WriteLine("Welcome to the linked list");
linked_list List = new linked_list();
List.create(56);
List.append(30);
List.append(40);
List.append(70);
Console.WriteLine("Before deleting of the node ");
List.print();
int position=List.search(40);
List.delete(40, position);
Console.WriteLine("After deleting of the node ");
List.print();
List.size();
