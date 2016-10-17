using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSystem
{
    public class ArrangeContainers
    {
        public List<string> containerStacks = new List<string>();
        public ArrangeContainers()
        { }
        public string ReadContainerFile(string fileInput)
        {
            string validationPassed = ValidateFile(fileInput);
            if (!string.IsNullOrEmpty(validationPassed))
            {
                return validationPassed;
            }
            //Split Test Cases By Line
            string[] lines = fileInput.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            
            int caseNumber = 1;
            //loop through each test case
            foreach (string testCase in lines.AsEnumerable())
            {
                if (testCase != "end")
                {
                    //possible recursion? - test each letter in the string
                    int index = 0;
                    containerStacks.Clear();
                    int numberOfStacks = LoadStacks(index, testCase);
                    Console.WriteLine("Case " + caseNumber + ":" + numberOfStacks.ToString());
                    caseNumber++;
                }
            }
            return "";
        }

        public int LoadStacks(int index, string testCase)
        { 
            while (index < testCase.Length)
            {
                char previousContainer = testCase[index == 0 ? index : index - 1];
                char currentContainer = testCase[index];

                //1.check if any stacks
                if (containerStacks.Any() && index > 0)
                { 
                    //2. check if previous stack = current stack - do nothing
                    if (previousContainer != currentContainer)
                    {
                        //3.previous container less than current container a < b - new stack
                        if (CheckPreviousCharLessThanCurrent(previousContainer, currentContainer))
                        {
                            //4.check if container doesnt already have a stack 
                            if (!containerStacks.Contains(currentContainer.ToString()))
                            {
                                containerStacks.Add(testCase[index].ToString());
                            }
                        }
                        else
                        {
                            //4.check if container doesnt already have a stack 
                            if (!containerStacks.Contains(currentContainer.ToString()))
                            {
                                int previousIndex = containerStacks.IndexOf(previousContainer.ToString());
                                containerStacks[previousIndex] = testCase[index].ToString();
                            }
                        }
                    }
                }
                else
                {
                    containerStacks.Add(testCase[index].ToString());
                }
                index++;
            }
            return containerStacks.Count();
        }

        public bool CheckPreviousCharLessThanCurrent(char previous, char current)
        {
            return previous < current;
        }

        public int NumberOfStacks(string testCase)
        {
            return testCase.Distinct().Count();
        }

        public string ValidateFile(string fileInput)
        {
            if (string.IsNullOrEmpty(fileInput))
            {
                return "File is Empty";
            }
            if (fileInput.Length > 1000)
            {
                return "File is Too Large";
            }
            if (!fileInput.ToUpper().Contains("END"))
            {
                return "File is Invalid";
            }
            if (fileInput.Any(char.IsDigit) || fileInput.Any(char.IsSymbol))//fileInput.Except("\n").Any(char.IsSymbol))
            {
                return "File is Invalid";
            }
            return "";
        }
    }
}
