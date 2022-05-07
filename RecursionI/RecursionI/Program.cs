﻿using System;
using RecursionI.SwapNodesInPairs;
using RecursionI.ReverseLinkedList;
using RecursionI.SearchInABinarySearchTree;
using RecursionI.PascalsTriangleII;
using RecursionI.FibonacciNumber;
using RecursionI.ClimbingStairs;
using RecursionI.MaximumDepthOfBinaryTree;
using RecursionI.PowXN;

namespace RecursionI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //SwapNodesInPairs();
            //ReverseLinkedList();
            //SearchInABinarySearchTree();
            //PascalsTriangleII();
            //FibonacciNumber();
            //ClimbingStairs();
            //MaximumDepthOfBinaryTree();
            PowXN();

            Console.Read();
        }

        private static void SwapNodesInPairs()
        {
            var solution = new SolutionSwapNodesInPairs();

            var listNode = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 3,
                        next = new ListNode
                        {
                            val = 4,
                            next = new ListNode
                            {
                                val = 5
                            }
                        }
                    }
                }
            };

            Console.Write($"{listNode.val} - {listNode.next.val} - {listNode.next.next.val} - {listNode.next.next.next.val} - {listNode.next.next.next.next.val}");

            Console.WriteLine();

            var res = solution.SwapPairs(listNode);

            Console.Write($"{res.val} - {res.next.val} - {res.next.next.val} - {res.next.next.next.val} - {res.next.next.next.next.val}");
        }

        private static void ReverseLinkedList()
        {
            var solution = new SolutionReverseLinkedList();

            var listNode = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 3,
                        next = new ListNode
                        {
                            val = 4,
                            next = new ListNode
                            {
                                val = 5
                            }
                        }
                    }
                }
            };

            Console.Write($"{listNode.val} - {listNode.next.val} - {listNode.next.next.val} - {listNode.next.next.next.val} - {listNode.next.next.next.next.val}");

            Console.WriteLine();

            var res = solution.ReverseList(listNode);

            Console.Write($"{res.val} - {res.next.val} - {res.next.next.val} - {res.next.next.next.val} - {res.next.next.next.next.val}");

        }

        private static void SearchInABinarySearchTree()
        {
            var sol = new SolutionSearchInABinarySearchTree();

            var tree = new TreeNode
            {
                val = 4,
                left = new TreeNode
                {
                    val = 2,
                    left = new TreeNode { val = 1 },
                    right = new TreeNode { val = 3 }
                },
                right = new TreeNode { val = 7 }
            };

            var result = sol.SearchBST(tree, 2);
        }

        private static void PascalsTriangleII()
        {
            var sol = new SolutionPascalsTriangleII();

            ExecuteTaseCase(sol, 0);
            ExecuteTaseCase(sol, 1);
            ExecuteTaseCase(sol, 2);
            ExecuteTaseCase(sol, 3);
            ExecuteTaseCase(sol, 4);
            ExecuteTaseCase(sol, 5);
            ExecuteTaseCase(sol, 6);
            ExecuteTaseCase(sol, 7);
            ExecuteTaseCase(sol, 8);

            static void ExecuteTaseCase(SolutionPascalsTriangleII solution, int rowIndex)
            {
                var res = solution.GetRow(rowIndex);
                foreach (var item in res)
                {
                    Console.Write($"{item},");
                }
                Console.WriteLine();
            }
        }

        private static void FibonacciNumber()
        {
            var sol = new SolutionFibonacciNumber();

            Console.WriteLine($"{sol.Fib(0)}");
            Console.WriteLine($"{sol.Fib(1)}");
            Console.WriteLine($"{sol.Fib(2)}");
            Console.WriteLine($"{sol.Fib(3)}");
            Console.WriteLine($"{sol.Fib(4)}");
            Console.WriteLine($"{sol.Fib(5)}");
            Console.WriteLine($"{sol.Fib(6)}");
            Console.WriteLine($"{sol.Fib(7)}");
        }

        private static void ClimbingStairs()
        {
            var sol = new SolutionClimbingStairs();

            Console.WriteLine($"{sol.ClimbStairs(1)}");
            Console.WriteLine($"{sol.ClimbStairs(2)}");
            Console.WriteLine($"{sol.ClimbStairs(3)}");
            Console.WriteLine($"{sol.ClimbStairs(4)}");
            Console.WriteLine($"{sol.ClimbStairs(5)}");
            Console.WriteLine($"{sol.ClimbStairs(6)}");
            Console.WriteLine($"{sol.ClimbStairs(44)}");
            Console.WriteLine($"{sol.ClimbStairs(45)}");
        }

        private static void MaximumDepthOfBinaryTree()
        {
            var sol = new SolutionMaximumDepthOfBinaryTree();

            //var tree = new TreeNode
            //{
            //    val = 3,
            //    left = new TreeNode { val = 9 },
            //    right = new TreeNode
            //    {
            //        val = 20,
            //        left = new TreeNode { val = 15 },
            //        right = new TreeNode { val = 7 }
            //    }
            //};

            var tree = new TreeNode
            {
                val = 3,
                left = new TreeNode { val = 9 },
                right = new TreeNode
                {
                    val = 20,
                    left = new TreeNode
                    {
                        val = 15,
                        left = new TreeNode { val = 11 }
                    },
                    right = new TreeNode { val = 7 }
                }
            };

            Console.WriteLine($"{sol.MaxDepth(tree)}");
        }

        private static void PowXN()
        {
            var sol = new SolutionPowXN();

            Console.WriteLine($"{sol.MyPow(2.0, 0)}");
            Console.WriteLine($"{sol.MyPow(2.0, 10)}");
            Console.WriteLine($"{sol.MyPow(2.1, 3)}");
            Console.WriteLine($"{sol.MyPow(2.0, -2)}");
            Console.WriteLine($"{sol.MyPow(34.00515, -3)}");
            Console.WriteLine($"{sol.MyPow(0.00001, 2147483647 - 10000)}");
            Console.WriteLine($"{sol.MyPow(1.0, 2147483647)}");
            Console.WriteLine($"{sol.MyPow(2.0, -2147483648)}");
            Console.WriteLine($"{sol.MyPow(-1.0, -2147483648)}");
        }
    }
}