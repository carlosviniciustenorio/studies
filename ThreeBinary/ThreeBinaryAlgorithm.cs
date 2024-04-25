// using System;

// class Node {
//     public int value;
//     public Node left, right;

//     public Node(int item) {
//         value = item;
//         left = right = null;
//     }
// }

// class BinaryTree {
//     Node root;

//     // Construtor
//     public BinaryTree() {
//         root = null;
//     }

//     // Método para inserir um novo nó
//     public void Insert(int value) {
//         root = InsertRecursive(root, value);
//     }

//     // Método auxiliar para inserção recursiva
//     private Node InsertRecursive(Node root, int value) {
//         if (root == null) {
//             root = new Node(value);
//             return root;
//         }

//         if (value < root.value) {
//             root.left = InsertRecursive(root.left, value);
//         } else if (value > root.value) {
//             root.right = InsertRecursive(root.right, value);
//         }

//         return root;
//     }

//     // Método para imprimir a árvore em ordem
//     public void InOrderTraversal() {
//         InOrderTraversalRecursive(root);
//     }

//     // Método auxiliar para percorrer em ordem recursivamente
//     private void InOrderTraversalRecursive(Node root) {
//         if (root != null) {
//             InOrderTraversalRecursive(root.left);
//             Console.Write(root.value + " ");
//             InOrderTraversalRecursive(root.right);
//         }
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         BinaryTree tree = new BinaryTree();

//         // Inserindo valores na árvore
//         tree.Insert(10);
//         tree.Insert(5);
//         tree.Insert(20);
//         tree.Insert(7);
//         tree.Insert(25);
//         tree.Insert(3);
//         tree.Insert(35);

//         // Imprimindo a árvore em ordem
//         Console.WriteLine("Árvore em ordem:");
//         tree.InOrderTraversal();
//     }
// }