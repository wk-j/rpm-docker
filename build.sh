#!/bin/sh
version=0.1
IMAGE=rpm
USERNAME=wearetherock

docker build -t $USERNAME/$IMAGE docker/CentOS
docker tag $USERNAME/$IMAGE:latest $USERNAME/$IMAGE:$version
docker push $USERNAME/$IMAGE:latest
docker push $USERNAME/$IMAGE:$version