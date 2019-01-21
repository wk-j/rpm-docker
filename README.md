## RPM

```bash
docker-compose down
docker-compose build
docker-compose up


docker run  \
    -it     \
    -v ('pwd')/working:/working     \
    dotnetrpm_centos sh "/working/build.sh"

docker run  \
     -it     \
    -v ('pwd')/working:/working     \
    dotnetrpm_centos sh
```

## My Web

```bash
rpmbuild --target noarch -bb /working/MyWeb.spec --define "_rpmdir $(pwd)"
rpm -i /working/noarch/my-web-1-1.noarch.rpm
rpm -e my-web

ls /usr/share/my-web
/usr/share/my-web/MyWeb
```

## Hello World

```bash
rpmbuild --target /working/noarch -bb /working/HelloWorld.spec --define "_rpmdir $(pwd)"
rpm -i working/noarch/hello-world-1-1.noarch.rpm
hello-world.sh

rpm -e hello-world
```
