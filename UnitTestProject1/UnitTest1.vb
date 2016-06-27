Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GitHubTest


<TestClass()> Public Class MyStuff_AddTwo_Test

    <TestMethod()> Public Sub MyStuff_AddTwo_Good()

        Dim z, a As Integer
        a = 2 + 2

        z = MyStuff.AddTwo(2, 2)
        Assert.AreEqual(z, a)

    End Sub
    <TestMethod()> Public Sub MyStuff_AddTwo_Bad()

        Dim z, a As Integer
        a = 2 + 5

        z = MyStuff.AddTwo(2, 2)
        Assert.AreNotEqual(z, a)

    End Sub
End Class
