# ML_line_follower_project
Reinforcement learning trainning for a line follower robot in Unity

## Requerimientos para ejecutar el proyecto
Crear un entorno virtual (venv) con python para el entrenamiento del modelo. Para esto se deben ejecutar los siguientes comandos en la terminal:

1. py -m venv venv
2. source venv\scripts\activate
3. python -m pip install --upgrade pip
4. pip3 install torch~=1.7.1 -f https://download.pytorch.org/whl/torch_stable.cmdhtml
5. python -m pip install mlagents==0.28.0
6. mlagents-learn —help (para verificar la correcta instalación de las librerias)