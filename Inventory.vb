Public Class Inventory
    Private m_invnum As String 'Inventory number
    Private m_descr As String 'Description about item
    Private m_cost As Decimal 'Cost of the item
    Private m_retail As Decimal 'Retail Price
    Private m_onhand As Integer 'Stock on hand

    'properties of above members
    Public Property InvNum() As String
        Get
            Return m_invnum
        End Get
        Set(value As String)
            m_invnum = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return m_descr
        End Get
        Set(value As String)
            m_descr = value
        End Set
    End Property

    Public Property Cost() As Decimal
        Get
            Return m_cost
        End Get
        Set(value As Decimal)
            m_cost = value
        End Set
    End Property

    Public Property Retail() As Decimal
        Get
            Return m_retail
        End Get
        Set(value As Decimal)
            m_retail = value
        End Set
    End Property

    Public Property OnHand() As Integer
        Get
            Return m_onhand
        End Get
        Set(value As Integer)
            If value > 0 Then
                m_onhand = value
            Else
                m_onhand = 0
            End If
        End Set
    End Property
End Class
