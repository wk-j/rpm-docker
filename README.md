## RPM

```bash
docker-compose down
docker-compose build
docker-compose up

docker run -it -v ('pwd')/.working:/working dotnetrpm_centos sh "/working/build.sh"
docker run -it -v ('pwd')/.working:/working dotnetrpm_centos sh
docker run -it -v ('pwd')/.working:/working -p 80:80 dotnetrpm_centos sh

docker run -it -p 5000:5000 dotnetrpm_app sh
```

## My Web

```bash
rpmbuild --target noarch -bb /working/MyWeb.spec --define "_rpmdir $(pwd)"
rpm -i /working/noarch/my-web-1-1.noarch.rpm
rpm -e my-web

ls /usr/share/my-web
```

## Start Service

```bash
systemctl enable MyWeb
systemctl start  MyWeb

docker rm (docker ps -a -q)
docker rmi (docker images -q --filter "dangling=true")
```