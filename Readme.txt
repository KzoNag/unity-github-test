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

【参考】
以下の記事を参考にさせて頂きました
・[Unity]Excelでデータを管理してUnity iOS/Androidで使うワークフローをもう少し詳しく（修正版）
http://terasur.blog.fc2.com/blog-entry-511.html

・[Unity]NPOI2.0.1(beta 1)を使ってxlsとxlsxを読み込んでみた
http://caitsithware.sakura.ne.jp/wordpress/?p=108

