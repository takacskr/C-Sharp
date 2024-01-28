using System;

// A bináris keresőfa csomópontjait reprezentáló osztály
class Node
{
    public int data; // A csomópont értéke
    public Node left, right; // A bal és jobb gyermek csomópontok

    // Konstruktor az érték beállítására
    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

// A bináris keresőfa osztálya
class BinarySearchTree
{
    Node root; // A fa gyökércsomópontja

    // Konstruktor a gyökércsomópont inicializálására
    public BinarySearchTree()
    {
        root = null;
    }

    // Beszúrási metódus a bináris keresőfába
    void Insert(int data)
    {
        root = InsertRec(root, data);
    }

    // Rekurzív segédmetódus a beszúráshoz
    Node InsertRec(Node root, int data)
    {
        // Ha a fa üres, létrehozunk egy új gyökércsomópontot
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        // Ellenőrizzük, hogy az új elem balra vagy jobbra kerüljön-e
        if (data < root.data)
            root.left = InsertRec(root.left, data);
        else if (data > root.data)
            root.right = InsertRec(root.right, data);

        return root;
    }

    // Inorder bejárás (bal-gyökér-jobb sorrend)
    void Inorder()
    {
        InorderRec(root);
    }

    // Rekurzív segédmetódus az inorder bejárás végrehajtásához
    void InorderRec(Node root)
    {
        if (root != null)
        {
            InorderRec(root.left);
            Console.Write(root.data + " ");
            InorderRec(root.right);
        }
    }

    // Main metódus a program futásának kezelésére
    public static void Main()
    {
        // Példányosítjuk a bináris keresőfa objektumot
        BinarySearchTree tree = new BinarySearchTree();

        // Néhány elemet beszúrunk a fába
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);

        // Kiíratjuk az inorder bejárást, hogy ellenőrizzük a fa rendezettségét
        Console.WriteLine("Inorder traversal of the constructed tree:");
        tree.Inorder();
    }
}
