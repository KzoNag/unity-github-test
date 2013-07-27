●●エクセル(.xls)ファイルのインポートテスト●●

【準備】
エクセルのファイルを扱うためのライブラリとしてNPOIを使用しています
ライブラリ自体はアップロードしていないので、下記からダウンロードしてください

http://npoi.codeplex.com/releases
(2.0 beta 1 のみ動作確認済み)

解凍後、dotnet3.5内のファイルを[Assets/Editor/dll/NPOI]に追加してください

【動作説明】
Editor/Data/CharaData.xlsをインポートしてAssets/Data/CharaData.assetsを生成・更新しています。
エクセルを編集・保存してUnityのエディタに戻ると自動的にReimportされて変更が反映されます。