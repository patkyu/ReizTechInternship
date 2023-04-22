using System;
using System.Collections.Generic;

class Branch
{
    public List<Branch> branches = new List<Branch>();
}

class Program
{
    static int CalculateDepth(Branch branch)
    {
        if (branch.branches.Count == 0)
        {
            // Base case: if the branch has no sub-branches, its depth is 1
            return 1;
        }
        else
        {
            // Recursive case: calculate the depth of each sub-branch and return the maximum
            int maxDepth = 0;
            foreach (Branch subBranch in branch.branches)
            {
                int subDepth = CalculateDepth(subBranch);
                if (subDepth > maxDepth)
                {
                    maxDepth = subDepth;
                }
            }
            return maxDepth + 1;
        }
    }

    static void Main(string[] args)
    {
        // Create a hierarchical structure of Branch objects
        Branch root = new Branch();
        for (int i = 0; i < 3; i++)
        {
            Branch level1 = new Branch();
            root.branches.Add(level1);
            for (int j = 0; j < 4; j++)
            {
                Branch level2 = new Branch();
                level1.branches.Add(level2);
                for (int k = 0; k < 2; k++)
                {
                    Branch level3 = new Branch();
                    level2.branches.Add(level3);
                    for (int l = 0; l < 5; l++)
                    {
                        Branch level4 = new Branch();
                        level3.branches.Add(level4);
                        for (int m = 0; m < 2; m++)
                        {
                            Branch level5 = new Branch();
                            level4.branches.Add(level5);
                        }
                    }
                }
            }
        }

        // Calculate the depth of the hierarchical structure using recursion
        int depth = CalculateDepth(root);

        // Print the depth to the console
        Console.WriteLine("The depth of the hierarchical structure is: " + depth);
    }
}
