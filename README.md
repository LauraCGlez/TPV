# TPV

Proyecto con el IDE Rider del TollBox de JetBrains y utilizando el puglin Avalonia para su diseño.
He utilizado varios contenedores para organizar y estructurar tu interfaz de usuario.

Window (Ventana):
xmlns: Define los espacios de nombres utilizados en el archivo XAML.
x:Class: Especifica la clase asociada en el código detrás.
Width y Height: Especifican el ancho y alto inicial de la ventana.
x:DataType: Asocia el tipo de datos de la ventana a un ViewModel.
Background: Establece el color de fondo de la ventana.
Title: Establece el título de la ventana.
Icon: Asigna un ícono a la ventana.

Grid (Cuadrícula):
RowDefinitions: Define las filas de la cuadrícula.
ColumnDefinitions: Define las columnas de la cuadrícula.
Contiene todos los elementos de la interfaz y organiza su disposición.

StackPanel (Panel de Pila):
Utilizado para agrupar elementos vertical u horizontalmente.
VerticalAlignment y HorizontalAlignment: Alinean el contenido dentro del panel.
Contiene elementos como etiquetas (TextBlock) y botones en este caso.

Button (Botón):
Utilizado para crear botones interactivos.
Width, Background: Establecen el ancho y el color de fondo del botón.
Contiene imágenes y etiquetas de texto.

Image (Imagen):
Muestra imágenes.
Source: Especifica la ruta de la imagen.

TextBlock (Bloque de Texto):
Muestra texto en la interfaz de usuario.
FontSize, FontFamily: Establecen el tamaño y la fuente del texto.
Text: Contiene el texto que se muestra.

UniformGrid (Cuadrícula Uniforme):
Organiza los elementos en una cuadrícula de manera uniforme.
Columns, Rows: Especifican el número de columnas y filas.

Border (Borde):
Agrega bordes a elementos para resaltar o separar visualmente.
BorderBrush, BorderThickness: Especifican el color y el grosor del borde.
