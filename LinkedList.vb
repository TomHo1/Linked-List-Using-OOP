Public Class LinkedList
    Private tail As Node
    Private head As Node

    Public Function FindItem(ByVal data As Integer) As Node
        Dim SearchValue As Node
        Dim f As Boolean = False
        SearchValue = head
        While Not IsNothing(SearchValue)
            If (data = SearchValue.data) Then
                f = True
                Exit While
            End If
            SearchValue = SearchValue.nextNode
        End While
        If (f = True) Then

            Return SearchValue
        Else
            Return Nothing
        End If

    End Function


    Public Sub AddItem(ByVal dataItem As String)
        Dim newNode As New Node
        newNode.data = dataItem
        If IsNothing(tail) Then
            tail = newNode
        Else
            AddNodeAtEndOfList(tail, newNode)
        End If
    End Sub

    Private Function AddNodeAtEndOfList(currentNode As Node, nodeToAdd As Node)
        If IsNothing(currentNode.nextNode) Then
            currentNode.nextNode = nodeToAdd
            Return True
        Else
            AddNodeAtEndOfList(currentNode.nextNode, nodeToAdd)
        End If
        Return True
    End Function




End Class
