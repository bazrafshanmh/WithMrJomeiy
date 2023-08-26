#!/bin/bash

input_directory="/home/moheb/moheb/Unity/WithMrJomeiy/Assets/Sprites/Arrows"
output_directory="/tmp/Arrows12"

mkdir -p "$output_directory"
a=1

for image_file in "$input_directory"/Arow*/*.png; do
    base_name=$(basename "$image_file" .png)
    output_dir="$output_directory/Arrow$a"
    mkdir -p "$output_dir"
    output_file="$output_dir/${base_name}.png"
    
    convert "$image_file" -trim "$output_file"
    
    a=$((a + 1))
done

echo "Image cropping completed."

