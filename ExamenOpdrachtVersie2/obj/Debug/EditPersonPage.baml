   M S B A M L   `   `   `  ����P  LExamenOpdrachtVersie2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ExamenOpdrachtVersie2ExamenOpdrachtVersie2  5      *    $ExamenOpdrachtVersie2.EditPersonPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ExamenOpdrachtVersie2     5        N� Title$  EditPersonPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��FirstNameTextBox��5      $��
First Name��5      5      �� 5   
   -   5        $��LastNameTextBox��5      $��	Last Name��5      $��1��5      5      �� 5   
   -   5        $��GenderComboBox��5       $��1��5      5!      (  "System.Windows.Controls.DatePicker  5"   
   -   5        $��BirthdateDatePicker��5$      $��1��5"      $��1��5#      5%      �� 5&   
   -   5        $��EditPersonBtn��5)      $��3��5&      $��2��5'      $��Edit Person��5(      {�.  5*   #   �� 5+   
   -   5        $��PersonListBox��5.      $��1��5+      $��2��5,      $��2��5-      5.      �� 5/   
   -   5        $��ReturnToMenuBtn��52      $��Return To Menu��50      $��3��51      52      53      54      