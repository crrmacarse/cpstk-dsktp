

Public Class ucAdvertisement

    Public _title As String
    Public _descript As String
    Public _schedule As String
    Public _imagepath As String
    Public _image As Image

    Property Icon As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            _image = value
        End Set
    End Property

    Property ImagePath As String
        Get
            Return _imagepath
        End Get
        Set(value As String)
            _imagepath = value
        End Set
    End Property

    Property Descript As String
        Get
            Return _descript
        End Get
        Set(value As String)
            _descript = value
            lblAdvertInfo.Text = _descript
        End Set
    End Property

    Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            lblAdvertTitle.Text = _title
        End Set
    End Property

    Property Schedule As String
        Get
            Return _schedule
        End Get
        Set(value As String)
            _schedule = value
            lblAdvertDate.Text = _schedule
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        _title = String.Empty
        _descript = String.Empty
        _schedule = String.Empty
    End Sub

    Public Sub New(ByVal title As String, ByVal descript As String, ByVal image As String, ByVal schedule As String)
        InitializeComponent()

        _title = title
        _descript = descript
        _imagepath = image
        _schedule = schedule

    End Sub

    Private Sub ucAdvertisement_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAdvertTitle.Text = Title
        lblAdvertInfo.Text = Descript
        lblAdvertDate.Text = Schedule

        'Dim folder As String = "C:\xampp\htdocs\CPUSTIK\img\events"
        'Dim filename As String = System.IO.Path.Combine(folder, _imagepath)
        'pbImage.Image = Image.FromFile(filename)

    End Sub


End Class
