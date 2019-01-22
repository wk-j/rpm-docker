Name: my-web
Version: 1
Release: 1
Summary: My Web
License: FIXME

%description
This is my first RPM package

%prep
# We have no source

%install
mkdir -p %{buildroot}/usr/share/my-web
mkdir -p %{buildroot}/etc/systemd/system
cp -a /working/publish/. %{buildroot}/usr/share/my-web
install /working/etc/systemd/system/MyWeb.service %{buildroot}/etc/systemd/system/MyWeb.service
chmod 0644 %{buildroot}/etc/systemd/system/MyWeb.service

%files
/usr/share/my-web/
/etc/systemd/system/MyWeb.service