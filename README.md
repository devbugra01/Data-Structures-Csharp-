# Data Structures in C#

My CENG203 (Data Structures) practice: building each data structure from scratch in C#.
The course is taught in C++. I write the same structures in C# (my main language, heading to Unity).

## Linked List (Week 3)

- [x] `Node` class (`data` + `next`)
- [x] Create nodes and link them by hand: `10 -> 20 -> 30 -> null`
- [x] Read pointer chains: `first.next.data` (20), `first.next.next.data` (30)
- [ ] Walk the list with a loop
- [ ] Insert at front / after a node
- [ ] Delete a node

## C++ to C# cheat sheet

| C++ (lecture) | C# (this repo) |
|---|---|
| `Node* next` | `Node? next` (classes are references) |
| `nullptr` | `null` |
| `first->next->data` | `first.next.data` |
| `delete p;` | Garbage collector |
