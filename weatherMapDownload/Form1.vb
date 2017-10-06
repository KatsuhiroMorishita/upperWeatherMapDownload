Public Class Form1
    ''' <summary>
    ''' タイマーが起動するごとに、気象庁のHPを確認して高層天気図をダウンロードする
    ''' 高層天気図はUTCで0時と12時の予報が出されている。
    ''' 2011/9/13時点では公開タイミングは分からん。
    ''' 
    ''' [開発履歴]
    ''' 2011/9/13 普通の天気図をダウンロードするソフトウェアを基に高層天気図をダウンロードするプログラムを製作開始
    '''           今回は一つのウィンドウの中に4つのピクチャーボックスを並べたが、これ以上に拡張するならマルチウィンドウにすべきだ。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub clockCheckTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clockCheckTimer.Tick
        Dim t As DateTime = Date.UtcNow                                         ' 高層天気図はUTC時刻を基に発表される
        Dim t2 As DateTime
        Dim wc As New System.Net.WebClient()
        Dim path As String
        Dim yy, mm, dd, hh As String
        Dim fname, savePath As String
        Dim hour As Integer
        Const releaseTime As Double = 48600.0                                   ' ある時刻分の天気図が公開されるまでの時間差（とりあえず、13時間30分後としてみる）

        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() Then  ' ネットに接続しているかを確認
            Me.ICCondition.Text = "Internet Connection Condition: Connect"      ' 接続できていることを示す。
            ' ダウンロードファイル名生成の準備
            t = t.AddSeconds(-releaseTime)                                      ' 既にリリースされている分がほしいので、リリースまでのディレイを引いて計算する
            hour = Math.Floor(t.Hour / 12) * 12
            yy = (t.Year Mod 100).ToString("d2")                                ' 時分秒を指定のフォーマットで文字列化する
            mm = (t.Month).ToString("d2")
            dd = t.Day.ToString("d2")
            hh = hour.ToString("d2")
            ' まずは500hPa
            fname = yy + mm + dd + "upper500hPa_" + hh + ".png"                 ' HDへ保存するときのファイル名を作る
            savePath = System.IO.Directory.GetCurrentDirectory() + "\" + fname
            t2 = New DateTime(t.Year, t.Month, t.Day, hour, 0, 0).AddSeconds(releaseTime)           ' ダウンロードしたいファイルのリリース時刻を少し余裕をもって計算する
            If System.IO.File.Exists(savePath) = False Then                                         ' ファイルが未ダウンロードならダウンロードする
                If t2 < Date.UtcNow Then                                                            ' 2時間10分経過していればダウンロードを実行する
                    Try
                        path = "http://www.jma.go.jp/jmh/wmapimgs/lrg_" + hh + "_auas50.png"
                        wc.DownloadFile(path, savePath)                                             ' ダウンロード
                        If hour = 0 Then Me.PicBox500_00.Image = System.Drawing.Image.FromFile(savePath) ' 読み込めたら、表示する
                        If hour = 12 Then Me.PicBox500_12.Image = System.Drawing.Image.FromFile(savePath)
                        Me.ErrorInfo.Text = "ダウンロードしました。"
                        t2 = t2.AddHours(12)                                                        ' 次のダウンロード時刻を計算する
                    Catch ex As Exception
                        Me.ErrorInfo.Text = "何らかのエラーが発生しました。orz"
                    End Try
                End If
            Else
                t2 = t2.AddHours(12)                                                                ' 既にダウンロード済みであった場合、次のダウンロード時刻を計算する
            End If
            ' 次は700hPa
            fname = yy + mm + dd + "upper700hPa_" + hh + ".png"                 ' HDへ保存するときのファイル名を作る
            savePath = System.IO.Directory.GetCurrentDirectory() + "\" + fname
            t2 = New DateTime(t.Year, t.Month, t.Day, hour, 0, 0).AddSeconds(releaseTime)           ' ダウンロードしたいファイルのリリース時刻を少し余裕をもって計算する
            If System.IO.File.Exists(savePath) = False Then                                         ' ファイルが未ダウンロードならダウンロードする
                If t2 < Date.UtcNow Then                                                            ' 2時間10分経過していればダウンロードを実行する
                    Try
                        path = "http://www.jma.go.jp/jmh/wmapimgs/lrg_" + hh + "_auas70.png"
                        wc.DownloadFile(path, savePath)                                             ' ダウンロード
                        If hour = 0 Then Me.PicBox700_00.Image = System.Drawing.Image.FromFile(savePath) ' 読み込めたら、表示する
                        If hour = 12 Then Me.PicBox700_12.Image = System.Drawing.Image.FromFile(savePath)
                        Me.ErrorInfo.Text = "ダウンロードしました。"
                        t2 = t2.AddHours(12)                                                        ' 次のダウンロード時刻を計算する
                    Catch ex As Exception
                        Me.ErrorInfo.Text = "何らかのエラーが発生しました。orz"
                    End Try
                End If
            Else
                t2 = t2.AddHours(12)                                                                ' 既にダウンロード済みであった場合、次のダウンロード時刻を計算する
            End If
            ' 最後は850hPa
            fname = yy + mm + dd + "upper850hPa_" + hh + ".png"                                     ' HDへ保存するときのファイル名を作る
            savePath = System.IO.Directory.GetCurrentDirectory() + "\" + fname
            t2 = New DateTime(t.Year, t.Month, t.Day, hour, 0, 0).AddSeconds(releaseTime)           ' ダウンロードしたいファイルのリリース時刻を少し余裕をもって計算する
            If System.IO.File.Exists(savePath) = False Then                                         ' ファイルが未ダウンロードならダウンロードする
                If t2 < Date.UtcNow Then                                                            ' 2時間10分経過していればダウンロードを実行する
                    Try
                        path = "http://www.jma.go.jp/jmh/wmapimgs/lrg_" + hh + "_auas85.png"
                        wc.DownloadFile(path, savePath)                                             ' ダウンロード
                        If hour = 0 Then Me.PicBox850_00.Image = System.Drawing.Image.FromFile(savePath) ' 読み込めたら、表示する
                        If hour = 12 Then Me.PicBox850_12.Image = System.Drawing.Image.FromFile(savePath)
                        Me.ErrorInfo.Text = "ダウンロードしました。"
                        t2 = t2.AddHours(12)                                                        ' 次のダウンロード時刻を計算する
                    Catch ex As Exception
                        Me.ErrorInfo.Text = "何らかのエラーが発生しました。orz"
                    End Try
                End If
            Else
                t2 = t2.AddHours(12)                                                                ' 既にダウンロード済みであった場合、次のダウンロード時刻を計算する
            End If
            Me.NextDwload.Text = "Next Download clock(UTC):" + t2.ToString                          ' ダウンロード時刻を表示する
            Me.NextDwload.Text += "   Last:" + CInt(Date.UtcNow.Subtract(t2).TotalSeconds).ToString() + "[s]"
        Else
            Me.ICCondition.Text = "Internet Connection Condition: Disconnect"
        End If
        wc.Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() Then  ' ネットに接続しているかを確認
            Me.ICCondition.Text = "Internet Connection Condition: Connect"
        Else
            Me.ICCondition.Text = "Internet Connection Condition: Disconnect"
        End If
    End Sub
End Class
