# IME-Events
An example of TextCompositionManager when input with CJK IME.

# 注音輸入法 (Microsoft Bopomofo)
1. Pressed <kbd>S</kbd>, text is now `ㄋ`

PreviewTextInputStart -> PreviewTextInputUpdate -> TextChanged

2. Pressed <kbd>U</kbd>, text is now `ㄋㄧ`

PreviewTextInputUpdate -> TextChanged

3. Pressed <kbd>3</kbd>, text is now `你`

PreviewTextInputUpdate -> TextChanged

4. Pressed <kbd>C</kbd>, text is now `你ㄏ`

PreviewTextInputUpdate -> TextChanged

5. Pressed <kbd>L</kbd>, text is now `你ㄏㄠ`

PreviewTextInputUpdate -> TextChanged

6. Pressed <kbd>3</kbd>, text is now `你好`

PreviewTextInputUpdate -> TextChanged

7. Pressed <kbd>Enter</kbd>, text is now `你好`

PreviewTextInputUpdate -> PreviewTextInput -> TextChanged

# 拼音輸入法 (Microsoft Pinyin)
1. Pressed <kbd>N</kbd>, text is now `n`

PreviewTextInputStart -> PreviewTextInputUpdate -> TextChanged

2. Pressed <kbd>I</kbd>, text is now `ni`

PreviewTextInputUpdate -> TextChanged

3. Pressed <kbd>H</kbd>, text is now `ni'h`

PreviewTextInputUpdate -> TextChanged

4. Pressed <kbd>A</kbd>, text is now `ni'ha`

PreviewTextInputUpdate -> TextChanged

5. Pressed <kbd>O</kbd>, text is now `ni'hao`

PreviewTextInputUpdate -> TextChanged

6. Pressed <kbd>Enter</kbd>, text is now `你好`

PreviewTextInputUpdate -> PreviewTextInput -> TextChanged

# Japanese Microsoft IME

1. Pressed <kbd>O</kbd>, text is now `お`

PreviewTextInputStart -> PreviewTextInputUpdate -> TextChanged

2. Pressed <kbd>H</kbd>, text is now `おｈ`

PreviewTextInputUpdate -> TextChanged

3. Pressed <kbd>I</kbd>, text is now `おは`

PreviewTextInputUpdate -> TextChanged

4. Pressed <kbd>I</kbd>, text is now `おはい`

PreviewTextInputUpdate -> TextChanged

5. Pressed <kbd>Y</kbd>, text is now `おはいｙ`

PreviewTextInputUpdate -> TextChanged

6. Pressed <kbd>O</kbd>, text is now `おはいよ`

PreviewTextInputUpdate -> TextChanged

7. Pressed <kbd>Enter</kbd>, text is now `おはいよ`

PreviewTextInputUpdate -> PreviewTextInput -> TextChanged

# Korean Hangeul IME

1. Pressed <kbd>G</kbd>, text is now `ㅎ`

PreviewTextInputStart -> TextChanged

2. Pressed <kbd>K</kbd>, text is now `하`

PreviewTextInputUpdate -> TextChanged

3. Pressed <kbd>S</kbd>, text is now `한`

PreviewTextInputUpdate -> TextChanged

4. Pressed <kbd>R</kbd>, text is now `한ㄱ`

PreviewTextInput -> PreviewTextInputStart -> TextChanged

5. Pressed <kbd>M</kbd>, text is now `한그`

PreviewTextInputUpdate -> TextChanged

6. Pressed <kbd>F</kbd>, text is now `한글`

PreviewTextInputUpdate -> TextChanged

7. Pressed <kbd>Enter</kbd>, text is now `한글`

PreviewTextInput -> PreviewTextInputStart -> PreviewTextInput
