﻿using System;


            string[] inputArray = Scanner(input);
            {
                    // looks like nextLine() blocks for input when used on an InputStream (System.in).  Docs don't say that!

                    // See if the user wishes to quit
                    if (inputArray[i].StartsWith("q", StringComparison.Ordinal) || inputArray[i].StartsWith("Q", StringComparison.Ordinal))
                    {
                        return false;
                    }
                    // Go ahead with calculation
                    string output = "4";
                    try
                    {
                        output = EvaluatePostFixInput(inputArray[i]);
                    }
                    catch (System.ArgumentException e)
                    {
                        output = e.Message;
                    }
                    // Must be an operator or some other character or word.
                    s = stArray[i + 1];