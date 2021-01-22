using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager_StudentCrack._Chat
{
    class SaveChatEXE
    {
        //TODO: 动态编译回复程序
        public static void CreateCodeEXE()
        {
            CSharpCodeProvider Provider = new CSharpCodeProvider();
            CompilerParameters Parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                GenerateInMemory = false,
                OutputAssembly = "test.exe",
                IncludeDebugInformation = true,  // 调试模式
                MainClass = "ClassManager_StudentCrack.Chat.Template.Reply",
                CompilerOptions = "-t:winexe"
            };

            Parameters.ReferencedAssemblies.Add("System.dll");
            Parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            Parameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
            Parameters.ReferencedAssemblies.Add("System.Core.dll");
            Parameters.ReferencedAssemblies.Add("System.Data.dll");
            Parameters.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll");
            Parameters.ReferencedAssemblies.Add("System.Deployment.dll");
            Parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            Parameters.ReferencedAssemblies.Add("System.Net.Http.dll");
            Parameters.ReferencedAssemblies.Add("System.Xml.dll");
            Parameters.ReferencedAssemblies.Add("System.Xml.Linq.dll");

            string[] Files = new string[] {
                @"H:\Porjects\Mythware\ClassManager_StudentCrack\Chat\Template\Reply.Designer.cs",
                @"H:\Porjects\Mythware\ClassManager_StudentCrack\Chat\Template\Reply.cs",
                @"H:\Porjects\Mythware\ClassManager_StudentCrack\Chat\Template\Main.cs"
            };

            // TODO: 更改相对路径
            CompilerResults _CompilerResults = Provider.CompileAssemblyFromFile(Parameters, Files);

            // 编译错误处理
            if (_CompilerResults.Errors.Count > 0)
            {
                StringBuilder StrBuild = new StringBuilder();
                foreach (var er in _CompilerResults.Errors)
                {
                    StrBuild.AppendLine(er.ToString());
                }
                System.Windows.Forms.MessageBox.Show(StrBuild.ToString());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Success!");
            }
        }
    }
}
