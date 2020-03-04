using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MoveFiles
    {
            public static void Move()
        {
            string sourceFile = @"F:\RWS\1\TestCopy.txt";
            string destinationFile = @"F:\RWS\2\TestCopy.txt";

            // To move a file or folder to a new location:
            System.IO.File.Move(sourceFile, destinationFile);
        }
    }
}
