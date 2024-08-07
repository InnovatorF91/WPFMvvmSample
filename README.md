App.xaml.cs:這個文件控制應用程序的啟動和退出。
MainWindow.xaml:這是主窗口的 XAML。它包含一個 ContentControl，其內容綁定到 CurrentView 屬性，允許動態切換視圖。
MainWindow.xaml.cs:這是主窗口的代碼後台。它初始化窗口並設置 DataContext 為 MainViewModel 的實例。
MainViewModel.cs:這是主要的 ViewModel。它管理當前顯示的視圖（LoginView 或 TopView），並實現了 INotifyPropertyChanged 接口以支持數據綁定。
LoginView.xaml:這是登錄視圖的 XAML，定義了用戶界面元素。
LoginView.xaml.cs:這是登錄視圖的代碼後台。它設置 DataContext 並處理 PasswordBox 的密碼變化。
LoginViewModel.cs:這是登錄視圖的 ViewModel。它處理登錄邏輯，驗證用戶名和密碼，並在登錄成功時切換到 TopView。
RelayCommand.cs:這是一個實現 ICommand 接口的通用命令類，用於在 MVVM 模式中綁定視圖的操作到 ViewModel 的方法。
這些代碼共同實現了一個使用 MVVM 模式的單一實例 WPF 應用程序，包括登錄功能和視圖切換。程序啟動時顯示登錄界面，登錄成功後切換到 Top 視圖，同時防止多個程序實例同時運行。
