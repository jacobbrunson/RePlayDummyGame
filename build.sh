msbuild DummyGame /p:Configuration=Debug
paket pack DummyGame
mkdir ../../../../RePlay/Assets/DummyGame/
cp -R DummyGame/Content/bin/Android/* ../../../../RePlay/Assets/DummyGame/
