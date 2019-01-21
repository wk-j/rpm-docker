## RPM

```bash
docker-compose down
docker-compose build
docker-compose up


docker run  \
    -it     \
    -v ('pwd')/working:/working     \
    dotnetrpm_centos sh
```

## Hello World

```bash
cd /working
rpmbuild --target noarch -bb HelloWorld.spec --define "_rpmdir $(pwd)"
rpm -i noarch/hello-world-1-1.noarch.rpm
hello-world.sh
rpm -e hello-world
```

## My Web

```bash
rpmbuild --target noarch -bb MyWeb.spec --define "_rpmdir $(pwd)"
rpm -e my-web
rpm -i noarch/my-web-1-1.noarch.rpm
ls /usr/share/my-web
./usr/share/my-web/MyWeb
```