Public Class Yarisma
    Dim sayac As Integer
    Dim cevapSayac As Integer
    Dim puan As Integer
    Dim soru As String
    Dim dogruCevap As String
    Dim cevapA As String
    Dim cevapB As String
    Dim cevapC As String
    Dim cevapD As String
    Private Sub Yarisma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        puan = 0
        sayac = 1
        basla()
    End Sub

    Sub basla()

        If sayac = 1 Then
            soru = "1) Türkiyenin başkenti neresidir ? "
            cevapA = "İstanbul"
            cevapB = "Ankara"
            cevapC = "Antalya"
            cevapD = "İzmir"
            dogruCevap = cevapB
        ElseIf sayac = 2 Then
            soru = "Gece gündüz eşitliği (ekinoks) bir yılda kaç kez gerçekleşir?"
            cevapA = "3 "
            cevapB = "1 "
            cevapC = "2 "
            cevapD = "5 "
            dogruCevap = cevapC
        ElseIf sayac = 3 Then
            soru = "İlk Türkçe sözlük hangisidir"
            cevapA = "Divan-ı Lugat-it Türk "
            cevapB = "Atabetü'l-Hakayık "
            cevapC = "Durub-i Emsal-ı Osmaniye "
            cevapD = "Letaif-i Rivayet "
            dogruCevap = cevapA
        ElseIf sayac = 4 Then
            soru = "Osmanlı Devleti'nde ilk nüfus sayımı hangi padişah zamanında yapılmıştır?"
            cevapA = "Fatih Sultan Mehmet "
            cevapB = "Kanuni Sultan Süleyman "
            cevapC = "I.Murat "
            cevapD = "II. Mahmut
 "
            dogruCevap = cevapD
        ElseIf sayac = 5 Then
            soru = "Atatürk tarafından 4 Eylül 1919 tarihinde Sivas Kongresi'nde kurulmuş olan gazetenin adı nedir ?"
            cevapA = "Cumhuriyet "
            cevapB = "Ceride-i Havadis "
            cevapC = "Takvim-i Vekayi "
            cevapD = "İrade-i Milliye "
            dogruCevap = cevapD
        ElseIf sayac = 6 Then
            soru = "Dünyanın ilk haritasını çizen ünlü Türk denizcisi kimdir?"
            cevapA = "Piri Reis "
            cevapB = "Barbaros Hayrettin Paşa "
            cevapC = "Umur Bey "
            cevapD = "Uluç Ali Reis "
            dogruCevap = cevapA
        ElseIf sayac = 7 Then
            soru = "Amerika kıtasını 2’ye ayıran önemli su geçidinin adı nedir?"
            cevapA = "Messina  "
            cevapB = "Panama "
            cevapC = "Süveyş "
            cevapD = "Bering  "
            dogruCevap = cevapB
        ElseIf sayac = 8 Then
            soru = "UEFA Kupasını alan ilk Türk takımı hangisidir?"
            cevapA = "Fenerbahçe "
            cevapB = "Beşiktaş "
            cevapC = "Galatasaray "
            cevapD = "Bursaspor "
            dogruCevap = cevapC
        ElseIf sayac = 9 Then
            soru = "Altın Palmiye Ödülleri hangi şehrimizde verilmektedir?"
            cevapA = "Sakarya "
            cevapB = "Mersin "
            cevapC = "Antalya "
            cevapD = "İstanbul "
            dogruCevap = cevapC
        ElseIf sayac = 10 Then
            soru = "Mimar Sinan'ın Ustalık Dönemi eseri sayılan Edirne'deki eserinin adı nedir?"
            cevapA = "Süleymaniye "
            cevapB = "Selimiye "
            cevapC = "Şehzade "
            cevapD = "Sinanpaşa "
            dogruCevap = cevapB
        Else
            MessageBox.Show("Tebrikler.  Bütün soruları doğru cevapladın. ", "DOĞRU")
            Me.Close()
            Form1.Show()
        End If
        TextBox1.Text = soru
        Button1.Text = cevapA
        Button2.Text = cevapB
        Button3.Text = cevapC
        Button4.Text = cevapD
        Label1.Text = puan.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dogruCevap = Button1.Text Then
            puan += 10
            MessageBox.Show("Tebrikler.  Sonraki soruya geç ", "DOĞRU")
        Else
            MessageBox.Show("Doğru cevap = " + dogruCevap + vbNewLine + "Puanınız: " + puan.ToString, "YANLIŞ CEVAP")
            Me.Close()
            Form1.Show()
        End If

        sayac += 1
        basla()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dogruCevap = Button2.Text Then
            puan += 10
            MessageBox.Show("Tebrikler.  Sonraki soruya geç ", "DOĞRU")
        Else
            MessageBox.Show("Doğru cevap = " + dogruCevap + vbNewLine + "Puanınız: " + puan.ToString, "YANLIŞ CEVAP")
            Me.Close()
            Form1.Show()
        End If
        sayac += 1
        basla()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dogruCevap = Button3.Text Then
            puan += 10
            MessageBox.Show("Tebrikler.  Sonraki soruya geç ", "DOĞRU")
        Else
            MessageBox.Show("Doğru cevap = " + dogruCevap + vbNewLine + "Puanınız: " + puan.ToString, "YANLIŞ CEVAP")
            Me.Close()
            Form1.Show()
        End If
        sayac += 1
        basla()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dogruCevap = Button4.Text Then
            puan += 10
            MessageBox.Show("Tebrikler.  Sonraki soruya geç ", "DOĞRU")
        Else
            MessageBox.Show("Doğru cevap = " + dogruCevap + vbNewLine + "Puanınız: " + puan.ToString, "YANLIŞ CEVAP")
            Me.Close()
            Form1.Show()
        End If
        sayac += 1
        basla()
    End Sub
End Class