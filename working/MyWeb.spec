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
cp -a /working/publish/. /usr/share/my-web
chmod 775 /usr/share/my-web/MyWeb

%files
/usr/share/my-web
