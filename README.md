# PinBall

> Jogo feito para um trabalho de motores

Esse jogo 2D é baseado em um jogo clássico de antigamente, o `Pinball`.

### Imagem para de ilustração
<div style="width:30%">
    <img src="https://brinquedosparacasadefesta.com.br/wp-content/uploads/2023/08/Multi-pinball-07.jpg" title="Imagem ilustrartiva do que é um pinball" alt="Imagem ilustrartiva do que é um pinball">
</div>

### Preview
<div style="width:40%">
    <img src=".DocsImage/pinball-preview-image.png" alt="Preview do pinball">
</div>

### Como mudar os Inputs dos Flippers e do Lançador
Para mudar os inputs, vá para os scripts que estão localizados em

```yaml
╭PinBall
│
├──╼ Assets
│   ├──╼ Scripts
│       ├──╼ FlipperController.cs
│       ├──╼ LauncherController.cs
```

No `LauncherController.cs`, encontre a função HandleInputs. Após ter encontrado, mude todas as condições que tiverem `KeyCode.DownArrow` para o input que você deseja. Abaixo está a preview da função HandleInputs do `LauncherController.cs`.
```csharp
if (Input.GetKey(KeyCode.DownArrow) && slide.value >= minValue)
{
    yield return new WaitForSeconds(0.1f);
    slide.value -= 0.1f;
    yield return new WaitForSeconds(0.1f);
}
else if (Input.GetKeyUp(KeyCode.DownArrow) && !Input.GetKey(KeyCode.DownArrow) && slide.value <= maxValue)
{
    while (slide.value <= slide.maxValue)
    {
        slide.value += 0.1f;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            break;
        }

        yield return new WaitForSeconds(0.002f);
    }
}
```
##

Para mudar os Inputs dos Flippers, vá para o arquivo `FlipperController.cs`. Abaixo está as condições que você vai mudar.

```csharp
if (Input.GetKeyDown(KeyCode.LeftArrow))
{
    _motor_left.motorSpeed = -350;
    _leftFliperHinge.motor = _motor_left;
}
else if (Input.GetKeyUp(KeyCode.LeftArrow))
{
    _motor_left.motorSpeed = 200;
    _leftFliperHinge.motor = _motor_left;
}
else if (Input.GetKeyDown(KeyCode.RightArrow))
{
    _motor_right.motorSpeed = 350;
    _rightFliperHinge.motor = _motor_right;
}
else if (Input.GetKeyUp(KeyCode.RightArrow))
{
    _motor_right.motorSpeed = -200;
    _rightFliperHinge.motor = _motor_right;
}
```

Você só TEM que mudar a parte que estiver com `Input.GetKeyDown(KeyCode.LeftArrow)` e/ou `Input.GetKeyDown(KeyCode.RightArrow)`.