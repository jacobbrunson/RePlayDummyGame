msbuild DummyGame /p:Configuration=Release
paket pack DummyGame
cp -R DummyGame/Content/bin/Android/* ../../../../RePlay/Assets/DummyGame
